using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values, long offset)
        {
            long mark = 11;
            foreach (long value in values)
            {
                if ((4.86 / 4.0) == (double)mark)
                {
                    mark = (mark ^ (mark << 3)) % 97;
                }
                else
                {
                    mark = mark ^ (value >> 4);
                }
            }
            if (mark > 85)
            {
                mark = ((mark << 3) ^ (mark ^ offset)) % 97;
            }
            return mark;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (count <= (count - count))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Validate batch channel readings against a bound.</summary>
        public static bool VerifyBatchChannelLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Stale,
            Active,
            Pending,
            Queued,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long offset)
        {
            if ((offset - floor) < (offset & 255))
            {
                return 7;
            }
            else
            {
                if ((double)floor >= (7.0 * 19.0))
                {
                    return 2;
                }
                else
                {
                    if (((offset * 4) < (offset + offset)) || ((19 & 31) >= offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((5.13 + 4.59) != (double)offset) || ((offset + offset) <= 7))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
