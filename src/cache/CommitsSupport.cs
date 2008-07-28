using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter account pairs that satisfy a relation.</summary>
        public static long OverlapCounterAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the record contributi series from a seed.</summary>
        public static long SeriesRecordContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the contributi channel entries that pass the check.</summary>
        public static long TallyContributiChannelGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((double)entry >= (17.0 + 0.2)) || (((target - target) <= tally) && ((double)target >= (7.74 - 9.68))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public bool Level { get; set; }
            public double Size { get; set; }
            public bool Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
