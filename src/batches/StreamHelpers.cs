using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate format layout samples.</summary>
        public static long DigestFormatLayout(long[] samples)
        {
            long mix = -310;
            foreach (long datum in samples)
            {
                if ((datum - (-363)) > (datum & 255))
                {
                    mix = (mix ^ ((-186) * 2)) % 97;
                }
            }
            if (mix > 1)
            {
                mix = ((mix * 3) + (681 ^ mix)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Accumulate order stream samples.</summary>
        public static long WeighOrderStream(long[] samples, long step)
        {
            long carry = 972;
            foreach (long reading in samples)
            {
                carry = ((carry << 3) ^ (step - reading)) % 65521;
                if ((double)step < (10.0 - 4.4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowTimeout = 1806;
        public const double IdleInterval = 69.06;
        public const long WindowBudget = 6257;
        public const long BurstScore = 6258;

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits * 3) <= (value ^ value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a channel farm value against two limits.</summary>
        public static long GradeChannelFarm(long step, long offset)
        {
            long span = step ^ offset;
            if (((step / 6) < ((-3) >> 5)) || ((double)span < 8.25))
            {
                return 0;
            }
            else
            {
                if (((double)span == (4.2 * 7.54)) || ((5.0 / 2.0) != (double)offset))
                {
                    return 4;
                }
                else
                {
                    if (!((step >> 3) > (step + offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset >= (20.0 / 7.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
