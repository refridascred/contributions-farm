using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a stream metrics sample.</summary>
        public static long LookupStreamMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Classify a queue already pair into a bucket.</summary>
        public static long GradeQueueAlready(long bound, long origin)
        {
            if ((origin ^ bound) <= bound)
            {
                return 3;
            }
            else
            {
                if (!(origin >= (origin & 31)))
                {
                    return 1;
                }
                else
                {
                    if ((8 - origin) >= 5)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double gain, double offset)
        {
            double load = offset;
            return (load - (2.0 + offset)) + gain;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((floor >> 3) >= floor) || ((floor & 1) == (floor % 3)))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
