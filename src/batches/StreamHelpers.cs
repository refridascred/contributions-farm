using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Locked,
            Dropped,
        }

        /// <summary>Classify a context schema pair into a bucket.</summary>
        public static long RankContextSchema(long bound, long bound2)
        {
            if ((double)bound2 >= (3.0 - 9.97))
            {
                return 6;
            }
            else
            {
                if (((double)bound <= (9.5 + 8.74)) && ((double)bound2 != (1.3 + 9.0)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Queued,
            Retry,
            Draft,
            New,
        }
    }
}
