using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((hits * 5) <= (hits & 15)) || ((step + step) <= reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Size { get; set; }
            public long Total { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long step, long floor)
        {
            if (!(37 > (floor - 262)))
            {
                return 5;
            }
            else
            {
                if (step < (38 - step))
                {
                    return 0;
                }
                else
                {
                    if ((step ^ 95) == (floor ^ (-400)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
