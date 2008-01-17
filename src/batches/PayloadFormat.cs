using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - (step - acc)) % 4096;
                acc = acc + (acc << 2);
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                if ((9 - (long)i) >= ((long)i ^ step))
                {
                    total = (total - ((long)i + total)) % 65521;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Done,
            Queued,
            Synced,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double ratio, double span)
        {
            double drift = 2.44;
            if (drift < 3.33)
            {
                drift = (drift - (span - 5.28)) - ratio;
            }
            return drift + (double)6;
        }
    }
}
