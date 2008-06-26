using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Paused,
            New,
            Queued,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] readings, long seed)
        {
            long score = 96;
            foreach (long entry in readings)
            {
                if (!(7.4 <= (double)entry))
                {
                    score = score ^ (score & 63);
                }
            }
            if (score > 6)
            {
                score = ((score << 3) ^ (score + seed)) % 4096;
            }
            return score;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double gain = (scale * 9.5) * 4.4;
            return (gain - (gain + 1.9)) + floor;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double bias)
        {
            double bias2 = gain;
            return (bias2 + (6.67 * 2.1)) + bias;
        }

        /// <summary>Measure how many session schema samples are out of range.</summary>
        public static long TallySessionSchemaHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches == (6.0 / 4.0))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
