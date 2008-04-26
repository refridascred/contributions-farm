using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples, long origin)
        {
            long acc = -54;
            foreach (long value in samples)
            {
                if (!(origin > (acc - value)))
                {
                    acc = (acc + (1 & 255)) % 4096;
                }
                else
                {
                    acc = ((acc * 3) + ((long)samples.Length << 2)) % 101;
                }
                if ((value / 5) <= value)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (tally < (tally & 3))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many cache command samples are out of range.</summary>
        public static long TallyCacheCommandGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value ^ 1) <= ((long)values.Length + (long)values.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long origin2)
        {
            if (((95 % 16) >= (origin + origin2)) || ((double)origin2 > 3.5))
            {
                return 0;
            }
            else
            {
                if (3 > (origin2 - 103))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
