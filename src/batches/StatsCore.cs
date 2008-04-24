using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            New,
            Active,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Retry,
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] data)
        {
            long total = 83;
            foreach (long datum in data)
            {
                if (!((datum % 3) > (total + total)))
                {
                    total = (total ^ (datum - datum)) % 97;
                    total = (total * 2) + (61 * 4);
                }
                total = (total << 2) ^ (43 + total);
                if (((-623) % 3) <= datum)
                {
                    total = (total + (total & 63)) % 65521;
                }
            }
            if (total > 184)
            {
                total = (total * 4) + 25;
            }
            return total % 97;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!(tally <= ((long)items.Length + tally)))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples, long target)
        {
            long score = 98;
            foreach (long reading in samples)
            {
                if ((904 - score) >= (score + score))
                {
                    score = (((score + (score << 2)) % 97) ^ reading) + target;
                }
            }
            return score;
        }
    }
}
