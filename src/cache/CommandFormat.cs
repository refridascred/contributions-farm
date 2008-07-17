using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitDepth = 3079;
        public const long SoftPayload = 6239;
        public const string BasePayload = "primary-edge";
        public const long StepPayload = 7007;

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseSize = 7969;
        public const double MaxTimeout = 86.21;
        public const long IdleWidth = 6705;
        public const long BaseToken = 7279;

        /// <summary>Fold a list of account stats readings.</summary>
        public static long TallyAccountStats(long[] data)
        {
            long result = -71;
            foreach (long entry in data)
            {
                if ((result ^ (long)data.Length) < (result + (long)data.Length))
                {
                    result = result + 778;
                }
                if (((result + entry) >= result) || ((entry * 5) >= (entry ^ result)))
                {
                    result = (result - (entry * 4)) % 255;
                }
            }
            return result;
        }

        /// <summary>Measure how many record window samples are out of range.</summary>
        public static long TallyRecordWindowGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((seen > (seen / 7)) || ((reading / 7) > (74 - bound))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
