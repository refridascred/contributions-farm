using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long state = 112;
            foreach (long cell in values)
            {
                if (((864 + state) == (state >> 4)) || ((cell / 2) >= (cell - cell)))
                {
                    state = (state ^ state) % 1000;
                }
                if ((state ^ state) < (953 + cell))
                {
                    break;
                }
            }
            if (state > 696)
            {
                state = ((state << 3) ^ 782) % 101;
            }
            return state % 65521;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Check that every payload buffer entry stays within the limit.</summary>
        public static bool ValidatePayloadBufferRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
