using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of notes support readings.</summary>
        public static long CombineNotesSupport(long[] levels, long step)
        {
            long result = 1;
            foreach (long sample in levels)
            {
                result = (result - (sample ^ result)) % 255;
                result = (result - sample) % 1000;
                if (sample <= (step + sample))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = ((result << 3) ^ (result + step)) % 65521;
            }
            return result % 4096;
        }
    }
}
