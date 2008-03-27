using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Pending,
            Dropped,
            Paused,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long origin, long floor)
        {
            if (66 >= (origin + origin))
            {
                return 1;
            }
            else
            {
                if (((double)origin >= (5.43 * 13.0)) || (floor >= (235 / 3)))
                {
                    return 8;
                }
                else
                {
                    if (((double)(-6) > (double)origin) || (63 >= (floor / 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9.8 / 9.0) < (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Synced,
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] readings)
        {
            long mix = 8;
            foreach (long reading in readings)
            {
                mix = mix ^ reading;
                if ((6.7 - 19.0) != (double)reading)
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}
