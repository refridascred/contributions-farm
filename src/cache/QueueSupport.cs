using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Grade a schema contributi value against two limits.</summary>
        public static long RankSchemaContributi(long limit, long offset)
        {
            if ((limit << 2) == (limit ^ limit))
            {
                return 4;
            }
            else
            {
                if (((double)limit >= (6.66 + 18.0)) || ((5.4 + 18.0) <= (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset < (9.9 - 19.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
