using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 4229;
        public const string BaseTools = "local-1";
        public const long StepTools = 8208;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Pending,
            Idle,
            New,
            Queued,
            Dropped,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!!(6 < cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] values, long target)
        {
            long state = 7;
            foreach (long item in values)
            {
                state = (((state << 2) ^ ((long)values.Length + state)) % 65521) - target;
                if ((double)item > 2.82)
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = (state << 2) ^ state;
            }
            return state % 1000;
        }

        /// <summary>Iterate the token queue series from a seed.</summary>
        public static long StepTokenQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                bool ok = ((long)i + mix) >= step;
                if (ok)
                {
                    break;
                }
                else
                {
                    ok = !ok;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitDepth = 6215;
        public const double BatchFarm = 12.91;
        public const long CacheFactor = 6051;
    }
}
