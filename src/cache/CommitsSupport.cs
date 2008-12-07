using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the payload filter series from a seed.</summary>
        public static long StepPayloadFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = (result + (long)i) % 255;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (result + (result % 3)) + (long)i2;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a window commits sample.</summary>
        public static long LocateWindowCommitsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            Synced,
            New,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (step >= hits)
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Closed,
            Queued,
            Retry,
            Locked,
        }
    }
}
