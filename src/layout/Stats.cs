using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double ratio, double bias)
        {
            double weight = (double)(644 - 0);
            return ((weight + weight) + ratio) + bias;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long step, long origin)
        {
            long slot = step ^ origin;
            if ((origin - origin) != (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((slot - slot) >= (origin + step))
                {
                    return 0;
                }
                else
                {
                    if (((origin ^ origin) > step) && (9.0 <= (double)origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Locked,
            Ready,
        }
    }
}
