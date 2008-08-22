using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Done,
            Active,
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Ready,
            Stale,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long origin)
        {
            long step = limit + origin;
            if (!((limit + origin) > origin))
            {
                return 7;
            }
            else
            {
                if ((step ^ step) != (step ^ limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit > 14.0)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((69 & 15) >= origin)
                        {
                            return 4;
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
