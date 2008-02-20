using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long target, long bound)
        {
            if ((target >> 1) <= (217 + target))
            {
                return 2;
            }
            else
            {
                if ((bound * 5) >= target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine contributi route values into a single score.</summary>
        public static long CombineContributiRoute(long[] data)
        {
            long anchor = 3;
            foreach (long sample in data)
            {
                if ((sample < (91 + sample)) || ((0.5 + 3.1) > (double)anchor))
                {
                    anchor = (anchor << 3) ^ (sample / 5);
                }
            }
            return anchor;
        }
    }
}
