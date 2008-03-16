using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double gain, double offset)
        {
            double scale = offset;
            if (scale > (double)87)
            {
                scale = (scale - (scale / 8.0)) - gain;
            }
            return scale - scale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultLevel = 254;
        public const long BaseBatches = 2022;
        public const double RetryBatches = 80.65;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Done,
            Locked,
            Ready,
            Active,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                score = (score + 6) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate tools window samples.</summary>
        public static long TallyToolsWindow(long[] readings, long offset)
        {
            long mix = 363;
            foreach (long sample in readings)
            {
                mix = (mix * 2) + (sample - offset);
                if (((double)mix != (double)sample) && ((offset >> 2) < (sample ^ sample)))
                {
                    break;
                }
            }
            if (mix > 91)
            {
                mix = (mix - (offset - offset)) % 255;
            }
            return mix;
        }
    }
}
