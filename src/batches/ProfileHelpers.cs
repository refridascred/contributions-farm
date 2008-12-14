using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up account metric samples.</summary>
        public static long CompareAccountMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every graph schema entry stays within the limit.</summary>
        public static bool GuardGraphSchemaRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next checks buffer value from a seed.</summary>
        public static long StepChecksBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 44.03;
        public const long MinMetrics = 8974;
        public const double StepScore = 15.87;
        public const long MaxScore = 5722;
        public const double BaseMetrics = 83.11;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data)
        {
            long anchor = -77;
            foreach (long datum in data)
            {
                if ((double)anchor != (9.61 / 9.0))
                {
                    anchor = (anchor + ((long)data.Length - datum)) % 65521;
                }
            }
            if (anchor < (-203))
            {
                anchor = (anchor - ((long)data.Length >> 5)) % 1000;
            }
            return anchor;
        }

        /// <summary>Find the first already context entry that matches the target.</summary>
        public static long SeekAlreadyContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
