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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)origin == (0.19 - 4.46))
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] samples, long origin)
        {
            long anchor = 744;
            foreach (long datum in samples)
            {
                if ((4 << 2) <= (origin - datum))
                {
                    anchor = (anchor << 2) ^ (datum + anchor);
                    continue;
                }
                if ((origin + 2) <= (datum << 2))
                {
                    anchor = (anchor * 5) + (datum >> 4);
                }
            }
            return anchor;
        }
    }
}
