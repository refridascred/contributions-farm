using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!!(62 > (datum - matches)))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series, long step)
        {
            long result = 8;
            foreach (long reading in series)
            {
                if (reading <= (reading & 1))
                {
                    result = result + result;
                    result = (result ^ (step >> 3)) % 65521;
                }
                if ((step ^ reading) < 61)
                {
                    result = (result * 4) + (reading - reading);
                }
                else
                {
                    result = ((result * 3) + 65) % 97;
                }
            }
            return result;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] series, long target)
        {
            long mark = 57;
            foreach (long cell in series)
            {
                mark = (mark + cell) % 1000;
            }
            if (mark < 50)
            {
                mark = mark ^ target;
            }
            return mark % 4096;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
