using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long origin, long offset)
        {
            long step = origin ^ offset;
            if (origin < (15 & 7))
            {
                return 1;
            }
            else
            {
                if (((offset & 31) < (step & 127)) && ((origin - offset) <= (origin & 7)))
                {
                    return 5;
                }
                else
                {
                    if (((origin + step) >= (1 - 6)) && (origin < (step ^ offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)origin >= (double)step) && ((step + offset) >= offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long origin, long offset)
        {
            if (!((0 - origin) != (offset + origin)))
            {
                return 5;
            }
            else
            {
                if (offset <= (origin % 60))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin < (0.1 - 7.2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Done,
            Retry,
            Pending,
        }
    }
}
