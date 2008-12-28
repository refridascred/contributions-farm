using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Idle,
            Done,
            Active,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long limit, long bound)
        {
            long prev = limit ^ bound;
            if (!((bound >> 3) == (prev + bound)))
            {
                return 3;
            }
            else
            {
                if (bound >= 67)
                {
                    return 0;
                }
                else
                {
                    if ((limit > (59 >> 2)) || (limit < (prev - bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit / 4) < (bound - prev)) || ((5 & 31) > prev))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
