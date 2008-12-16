using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowWidth = 2744;
        public const long StepCommits = 204;
        public const long DefaultCommits = 156;

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data, long target)
        {
            long acc = -7;
            foreach (long entry in data)
            {
                if ((entry / 6) > (0 - entry))
                {
                    acc = ((acc ^ (entry + entry)) % 4096) - target;
                }
            }
            return acc;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long limit, long offset)
        {
            if (offset <= limit)
            {
                return 2;
            }
            else
            {
                if (!((limit & 3) <= (limit - limit)))
                {
                    return 3;
                }
                else
                {
                    if (!((8 - 449) < (offset ^ limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset * 5) >= (limit - limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Done,
            Closed,
            Dropped,
            Locked,
        }
    }
}
