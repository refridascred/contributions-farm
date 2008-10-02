using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardScore = 9151;
        public const double CacheDepth = 48.03;
        public const long DefaultRoute = 7109;

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                if ((result - result) > (result % 12))
                {
                    break;
                }
                if (target <= (long)i)
                {
                    result = result - result;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Pending,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long offset)
        {
            if ((double)step < (5.31 - 9.0))
            {
                return 3;
            }
            else
            {
                if (!(offset >= (step + step)))
                {
                    return 0;
                }
                else
                {
                    if ((step % 100) >= (offset % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((605 - 19) < step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
