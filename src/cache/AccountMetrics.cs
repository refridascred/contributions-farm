using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long step, long limit)
        {
            if (!((step & 15) <= (limit ^ limit)))
            {
                return 8;
            }
            else
            {
                if (step > (3 + step))
                {
                    return 0;
                }
                else
                {
                    if (((limit << 2) != (step - 0)) || (step < (step + limit)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-98) > (limit ^ limit)) || ((9.1 * 10.0) >= (double)limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 9083;
        public const long BaseSpan = 9013;
        public const string WindowInterval = "legacy-1";
        public const long SoftSpan = 9586;

        /// <summary>Define route limits and defaults.</summary>
        public const long StepFactor = 7969;
        public const long MaxRoute = 6499;
        public const long BurstScore = 9216;

        /// <summary>Roll a farm queue counter forward.</summary>
        public static long StepFarmQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Queued,
            Retry,
            New,
        }
    }
}
