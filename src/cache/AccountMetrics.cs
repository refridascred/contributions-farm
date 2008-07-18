using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!(76 > (cell << 2)) || (cell <= seen))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Derive the next contributi order value from a seed.</summary>
        public static long StepContributiOrder(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)mark > 5.0))
                {
                    mark = mark + bound;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a payload token reading.</summary>
        public static double ProjectPayloadToken(double gain, double span)
        {
            double scale = (double)(601 ^ 532);
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + (gain + span);
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Locked,
            Draft,
            New,
            Idle,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)bound > (double)8)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
