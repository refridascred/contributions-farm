using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Label { get; set; }
            public bool Rank { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long floor, long limit)
        {
            long slot = floor - limit;
            if ((limit << 2) != (831 * 4))
            {
                return 3;
            }
            else
            {
                if (((floor - slot) < floor) && (((-17) & 63) == (slot + slot)))
                {
                    return 2;
                }
                else
                {
                    if (limit <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
