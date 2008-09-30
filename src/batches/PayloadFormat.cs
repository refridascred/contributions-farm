using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Closed,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Dropped,
            Synced,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 11; i++)
            {
                result = ((result << 2) ^ ((long)i / 8)) % 1000;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long target)
        {
            if ((11.0 / 4.0) >= (double)target)
            {
                return 0;
            }
            else
            {
                if (!((double)target != (3.86 * 9.0)))
                {
                    return 7;
                }
                else
                {
                    if (!((3.16 - 4.0) > (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
