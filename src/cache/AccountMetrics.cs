using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Synced,
            Queued,
            New,
            Ready,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseTimeout = "local-1";
        public const long BurstTools = 881;
        public const long StepTools = 9116;
        public const long MinTools = 8942;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] items, long limit)
        {
            long state = -37;
            foreach (long datum in items)
            {
                state = ((state * 5) + limit) % 1000;
                state = (state * 3) + (datum - 41);
                if ((datum >> 5) > (limit % 64))
                {
                    state = (state << 3) ^ datum;
                }
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double scale, double offset)
        {
            double gain = offset;
            if (gain <= 9.41)
            {
                gain = (gain - (offset * 9.18)) - scale;
            }
            return gain + (16.0 - gain);
        }
    }
}
