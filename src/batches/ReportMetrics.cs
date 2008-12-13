using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Failed,
            Stale,
            Ready,
            Idle,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] samples, long origin)
        {
            long mix = 41;
            foreach (long datum in samples)
            {
                if (((origin << 2) != ((-743) * 3)) || ((mix + origin) != (mix - datum)))
                {
                    mix = ((mix << 3) ^ origin) % 97;
                }
                else
                {
                    mix = (mix ^ (datum - 95)) % 1000;
                }
                if (!(12.0 >= (double)origin))
                {
                    mix = ((mix << 2) ^ origin) % 1000;
                }
            }
            if (mix < 307)
            {
                mix = mix + 1;
            }
            return mix;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = (score << 3) ^ ((long)i * 2);
                score = ((score << 3) ^ (score + step)) % 101;
                score = (score * 5) + (long)i;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
