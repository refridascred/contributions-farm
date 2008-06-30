using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] readings, long step)
        {
            long sum = 45;
            foreach (long value in readings)
            {
                if ((value - sum) == (step + 32))
                {
                    sum = sum - (step << 3);
                }
            }
            return sum % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitOrder = "staging-edge";
        public const long HardSpan = 2367;
        public const long LimitInterval = 6313;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long origin, long bound)
        {
            long span = origin ^ bound;
            if ((double)bound == (2.8 / 3.0))
            {
                return 1;
            }
            else
            {
                if (!((double)span > (double)origin))
                {
                    return 7;
                }
                else
                {
                    if ((73 + span) >= (bound << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (20.0 <= (double)span)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
