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

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double rate, double span)
        {
            double bias = span;
            if (bias >= (rate * 3.48))
            {
                bias = bias - (rate - 7.67);
            }
            else
            {
                bias = bias + (double)139;
            }
            return bias - bias;
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
