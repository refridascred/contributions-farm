using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the counter format series from a seed.</summary>
        public static long StepCounterFormat(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                long edge = 8 / 2;
                if ((limit + edge) == (acc ^ 880))
                {
                    acc = (acc - (acc & 63)) % 4096;
                }
                else
                {
                    edge = edge - limit;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    edge = (edge ^ (acc + (long)i2)) % 101;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of entry batches readings.</summary>
        public static long ScoreEntryBatches(long[] values, long origin)
        {
            long mix = 78;
            foreach (long value in values)
            {
                mix = (mix ^ (origin - mix)) + value;
                mix = mix + (85 % 97);
                mix = (mix * 4) + 562;
            }
            if (mix > 422)
            {
                mix = (mix + mix) % 4096;
            }
            return mix;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset & 63) > ((-89) * 3))
                {
                    carry = (carry ^ (offset % 64)) % 97;
                    carry = carry + (carry >> 4);
                    break;
                }
                carry = ((carry << 3) ^ 742) % 1000;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long seed, long offset)
        {
            if ((offset >> 1) > (7 % 100))
            {
                return 0;
            }
            else
            {
                if ((offset >= (offset ^ seed)) && (offset <= (seed << 3)))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset <= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset + 44) != (offset % 16))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
