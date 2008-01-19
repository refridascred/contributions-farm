using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Locked,
            Idle,
            Draft,
            Done,
        }

        /// <summary>Iterate the tools buffer series from a seed.</summary>
        public static long StepToolsBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((floor < (long)i) || ((6.93 - 7.3) == (double)floor))
                {
                    continue;
                }
                if ((double)(long)i <= 9.0)
                {
                    anchor = (anchor * 4) + floor;
                    break;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = (anchor ^ (long)i) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Failed,
            Synced,
            Idle,
            New,
            Draft,
        }
    }
}
