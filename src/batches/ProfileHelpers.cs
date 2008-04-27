using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double bias = 6.81;
            if (bias >= (bias / 4.0))
            {
                bias = bias + (span / 7.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - rate) + (double)(long)i;
            }
            return bias + (9.8 + rate);
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double weight = (double)(-25) * 7.3;
            if (weight < (double)55)
            {
                weight = (weight - bias) - offset;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - bias;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchSize = "latest-edge";
        public const string StepLayout = "local";
        public const double HardLayout = 71.73;
        public const string IdleLayout = "strict-edge";

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] values)
        {
            long mix = 8;
            foreach (long item in values)
            {
                if (mix >= ((-1) + mix))
                {
                    mix = ((mix << 2) ^ (78 << 3)) ^ item;
                }
            }
            if (mix > 905)
            {
                mix = ((mix << 2) ^ ((long)values.Length * 2)) % 97;
            }
            return mix;
        }
    }
}
