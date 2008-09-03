using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long floor, long offset)
        {
            if (((floor & 255) <= offset) || ((floor * 4) == (offset - offset)))
            {
                return 7;
            }
            else
            {
                if (!((floor + floor) < (offset << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((2 ^ floor) != (offset - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor - offset) != (floor + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine profile checks values into a single score.</summary>
        public static long WeighProfileChecks(long[] data)
        {
            long acc = 250;
            foreach (long cell in data)
            {
                if ((double)cell <= 0.8)
                {
                    acc = ((acc * 4) + (cell >> 4)) % 101;
                }
                if (((acc + acc) != (cell % 16)) && ((cell ^ acc) >= (0 % 2)))
                {
                    acc = acc + (acc ^ cell);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Draft,
            Pending,
            Locked,
            Done,
            Synced,
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
