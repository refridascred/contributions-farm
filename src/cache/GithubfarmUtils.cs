using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double gain, double floor)
        {
            double load = floor;
            if (load > (0.5 / 9.0))
            {
                load = load + load;
            }
            return load - (gain / 4.0);
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data, long origin)
        {
            long mix = 846;
            foreach (long cell in data)
            {
                if (cell >= (cell << 3))
                {
                    mix = ((mix << 3) ^ (mix << 1)) % 97;
                }
            }
            if (mix < 60)
            {
                mix = (mix << 3) ^ origin;
            }
            return mix % 65521;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Synced,
            Pending,
            Paused,
            Idle,
        }
    }
}
