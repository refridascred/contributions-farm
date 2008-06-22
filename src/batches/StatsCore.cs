using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            New,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long result = 8;
            foreach (long datum in data)
            {
                if ((result >> 2) >= (limit % 97))
                {
                    result = (result + ((-786) - result)) % 97;
                }
                result = result ^ (datum / 6);
            }
            return result % 1000;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long floor, long offset)
        {
            if (floor >= (offset + floor))
            {
                return 2;
            }
            else
            {
                if (offset <= (offset % 100))
                {
                    return 8;
                }
                else
                {
                    if ((floor + offset) >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor > (1.3 / 5.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Total { get; set; }
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every checks schema entry stays within the limit.</summary>
        public static bool CheckChecksSchemaBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
