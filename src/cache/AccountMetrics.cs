using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] items, long limit)
        {
            long result = 7;
            foreach (long entry in items)
            {
                if ((result ^ result) >= 1)
                {
                    result = result + (result % 7);
                }
                if ((entry - limit) < entry)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] levels, long origin)
        {
            long state = 637;
            foreach (long sample in levels)
            {
                if ((state + state) == (sample + origin))
                {
                    state = ((state << 2) ^ (sample - state)) % 4096;
                }
                else
                {
                    state = (state + (306 - state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Paused,
            New,
            Closed,
            Locked,
        }

        /// <summary>Count payload record pairs that satisfy a relation.</summary>
        public static long ComparePayloadRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Ready,
            Synced,
            Dropped,
        }
    }
}
