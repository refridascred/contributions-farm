using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Locked,
            Stale,
            Idle,
            Retry,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum & 127) < (matches ^ matches))
                {
                    matches = (matches + 1) - offset;
                }
            }
            return matches;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long target, long origin)
        {
            if (((double)origin == (3.7 - 4.0)) && (origin > (origin & 1)))
            {
                return 5;
            }
            else
            {
                if (!((double)target != (double)origin))
                {
                    return 4;
                }
                else
                {
                    if (target < (origin + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a support order value against two limits.</summary>
        public static long BucketSupportOrder(long bound, long target)
        {
            long bound2 = bound ^ target;
            if ((double)target >= (double)bound2)
            {
                return 2;
            }
            else
            {
                if ((double)target < 9.0)
                {
                    return 7;
                }
                else
                {
                    if ((bound2 % 10) < (bound2 + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound <= (3 % 60)) || (5.6 <= (double)bound2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
