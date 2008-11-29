using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] series)
        {
            long mix = 78;
            foreach (long cell in series)
            {
                if ((mix * 5) > cell)
                {
                    mix = ((mix << 2) ^ (mix - mix)) % 4096;
                }
                if ((mix < (96 << 3)) || ((cell + (-318)) > 7))
                {
                    break;
                }
            }
            if (mix > 30)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public double Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Look up the position of a queue token sample.</summary>
        public static long FindQueueTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
