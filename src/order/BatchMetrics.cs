using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            New,
            Draft,
            Locked,
            Synced,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowSpan = "latest-edge";
        public const long WindowLevel = 7663;
        public const long StepRatio = 635;

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 2742;
        public const double BatchCount = 48.63;
        public const long IdleCount = 2521;

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data, long step)
        {
            long mark = 646;
            foreach (long sample in data)
            {
                if ((mark + sample) >= mark)
                {
                    mark = ((mark ^ (sample & 15)) % 101) + step;
                }
            }
            if (mark < 9)
            {
                mark = mark + (5 / 6);
            }
            return mark;
        }
    }
}
