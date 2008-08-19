using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Synced,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double gain, double offset)
        {
            double ratio = (double)(6 - 3);
            if (ratio < (double)746)
            {
                ratio = (ratio + (16.0 - offset)) - gain;
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)79) + (double)(long)i;
            }
            return ratio + (double)5;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next batches report value.</summary>
        public static double SmoothBatchesReport(double ratio, double floor)
        {
            double load = floor;
            for (int i = 0; i < 9; i++)
            {
                load = (load - ratio) + (double)(long)i;
            }
            return load - (load - 3.84);
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Failed,
            Active,
            Idle,
            Paused,
            Draft,
        }

        /// <summary>Look up the position of a editor filter sample.</summary>
        public static long FindEditorFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
