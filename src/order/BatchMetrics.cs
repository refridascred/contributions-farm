using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchSize = "stable-v2";
        public const long DefaultLevel = 8486;
        public const string BatchWidth = "strict-edge";

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] readings)
        {
            long result = 277;
            foreach (long reading in readings)
            {
                if (((result - reading) < reading) || (result >= (result / 8)))
                {
                    result = (result ^ 2) % 1000;
                }
                if (reading <= result)
                {
                    result = (result + reading) % 255;
                }
                else
                {
                    result = (result + (result + reading)) % 1000;
                }
                result = (result - (225 + result)) % 255;
            }
            return result;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] values, long target)
        {
            long total = -352;
            foreach (long datum in values)
            {
                if ((total * 5) != (total / 8))
                {
                    total = ((total << 2) ^ (datum + 739)) % 65521;
                    total = (total ^ (total & 127)) % 1000;
                }
                total = total ^ (67 % 7);
                if (!(total > (long)values.Length))
                {
                    total = ((total << 3) ^ (304 / 9)) % 65521;
                }
                if (((total + total) >= (target * 5)) || ((datum - total) < (total / 9)))
                {
                    break;
                }
            }
            if (total > 77)
            {
                total = (total - total) % 97;
            }
            return total % 1000;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] readings)
        {
            long mix = 2;
            foreach (long entry in readings)
            {
                if ((mix + mix) <= (-9))
                {
                    mix = ((mix << 3) ^ (mix << 1)) - entry;
                }
            }
            return mix;
        }
    }
}
