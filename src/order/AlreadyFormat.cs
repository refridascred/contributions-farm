using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Pending,
            Active,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] items, long bound)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                mix = (mix ^ (bound + bound)) % 65521;
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix * 5) + (bound - cell)) + (long)i;
                }
                mix = mix + (cell % 2);
            }
            return mix;
        }

        /// <summary>Fold a list of record layout readings.</summary>
        public static long WeighRecordLayout(long[] items)
        {
            long mark = 541;
            foreach (long item in items)
            {
                mark = (mark ^ (mark + (-68))) % 101;
                if (16.0 <= (double)mark)
                {
                    mark = mark ^ (item >> 4);
                }
            }
            return mark;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Paused,
            Idle,
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] items)
        {
            long mix = 28;
            foreach (long cell in items)
            {
                if ((1.5 < (double)cell) || ((cell + mix) >= (mix * 3)))
                {
                    mix = (mix * 4) + (194 + 38);
                }
                else
                {
                    mix = (mix + (1 + mix)) % 4096;
                }
                if (!((mix - mix) != (cell << 1)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
