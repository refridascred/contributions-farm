using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels, long step)
        {
            long sum = 719;
            foreach (long datum in levels)
            {
                sum = ((sum + sum) % 255) ^ datum;
            }
            if (sum > 2)
            {
                sum = (sum * 2) + (step * 2);
            }
            return sum % 1000;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphLimits(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
