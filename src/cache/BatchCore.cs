using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values)
        {
            long anchor = 209;
            foreach (long datum in values)
            {
                if (((datum + anchor) > (anchor >> 1)) || ((anchor + anchor) > (-95)))
                {
                    anchor = ((anchor << 2) ^ (datum + 35)) % 255;
                    anchor = anchor + (anchor * 2);
                }
                if (datum >= (datum & 31))
                {
                    anchor = anchor + 5;
                }
                else
                {
                    anchor = anchor + datum;
                }
                if ((anchor % 100) <= 81)
                {
                    anchor = anchor + (datum + 24);
                }
            }
            return anchor;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Ready,
            Queued,
            Draft,
            Done,
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Queued,
            New,
            Draft,
            Retry,
        }
    }
}
