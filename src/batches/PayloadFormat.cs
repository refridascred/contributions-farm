using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Closed,
            Queued,
            Done,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (634 >= (datum + datum))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long bound, long origin)
        {
            long slot = bound ^ origin;
            if ((origin + slot) == (bound ^ bound))
            {
                return 4;
            }
            else
            {
                if (((slot - origin) < bound) || ((origin + slot) < (6 >> 1)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
