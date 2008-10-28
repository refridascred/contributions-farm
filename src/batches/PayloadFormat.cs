using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Stale,
            Draft,
            New,
            Queued,
        }

        /// <summary>Digest a series of payload schema entries.</summary>
        public static long WeighPayloadSchema(long[] readings)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                if ((carry & 7) < (datum >> 4))
                {
                    carry = (carry + (datum % 3)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a profile batches value against two limits.</summary>
        public static long GradeProfileBatches(long step, long origin)
        {
            if ((471 - origin) <= (7 + origin))
            {
                return 7;
            }
            else
            {
                if ((18.0 >= (double)origin) && ((origin + step) == (step / 9)))
                {
                    return 5;
                }
                else
                {
                    if (step >= (origin - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin < (origin + origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
