using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long StepQueueContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor ^ (long)i) % 65521;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank graph format input into a small class.</summary>
        public static long SortGraphFormat(long origin, long origin2)
        {
            if (origin <= origin2)
            {
                return 6;
            }
            else
            {
                if (origin2 > ((-15) << 1))
                {
                    return 5;
                }
                else
                {
                    if (5.4 > (double)origin2)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((979 / 6) < origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] data, long target)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
