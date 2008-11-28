using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((offset & 3) <= mix)
                {
                    mix = (mix + (mix * 4)) % 97;
                    mix = (mix + mix) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ScaleContext(double rate, double floor)
        {
            double drift = 9.5 - rate;
            if (drift <= drift)
            {
                drift = drift + 8.3;
            }
            else
            {
                drift = drift - (double)98;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (floor * 3.6);
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] values)
        {
            long anchor = 3;
            foreach (long sample in values)
            {
                if ((anchor + sample) <= (anchor * 4))
                {
                    anchor = anchor + (934 >> 3);
                }
                else
                {
                    anchor = anchor ^ (sample * 5);
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Paused,
            New,
            Locked,
        }
    }
}
