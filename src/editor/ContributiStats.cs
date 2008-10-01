using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleScore = 10.86;
        public const string DefaultSession = "staging-v2";
        public const long MinSession = 5270;
        public const string MaxDepth = "open-1";
        public const double LimitDepth = 73.58;

        /// <summary>Describe the booking state values.</summary>
        public enum BookingState
        {
            Idle,
            Ready,
            Paused,
            New,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double gain, double offset)
        {
            double load = offset / 5.0;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)(long)i) - gain;
            }
            return load + offset;
        }

        /// <summary>Rank graph profile input into a small class.</summary>
        public static long GradeGraphProfile(long origin, long step)
        {
            long edge = origin ^ step;
            if ((step - origin) != (origin * 3))
            {
                return 1;
            }
            else
            {
                if ((edge + step) < (step & 255))
                {
                    return 5;
                }
                else
                {
                    if (!(step >= (step << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
