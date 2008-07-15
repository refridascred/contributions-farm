using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values)
        {
            long score = 526;
            foreach (long datum in values)
            {
                score = score + (score - score);
                score = score + (datum + score);
                score = (score - (-7)) % 255;
            }
            if (score > 3)
            {
                score = (score ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate batch editor samples.</summary>
        public static long CombineBatchEditor(long[] series)
        {
            long total = 7;
            foreach (long datum in series)
            {
                if ((datum & 31) == (total << 2))
                {
                    total = total - (datum % 60);
                }
                else
                {
                    total = (total * 3) + datum;
                }
            }
            return total;
        }

        /// <summary>Audit commits window readings against a rule.</summary>
        public static long AuditCommitsWindowGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (89 >= (matches % 64))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }
    }
}
