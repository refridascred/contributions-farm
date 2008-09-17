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

        /// <summary>Count the githubfarm filter entries that pass the check.</summary>
        public static long AuditGithubfarmFilterHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (cell <= (306 & 31))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples, long offset)
        {
            long mix = 56;
            foreach (long cell in samples)
            {
                if (cell < mix)
                {
                    mix = ((mix * 3) + (offset % 8)) % 97;
                }
            }
            return mix % 97;
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
