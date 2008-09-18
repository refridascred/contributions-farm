using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Done,
            New,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every report metrics entry stays within the limit.</summary>
        public static bool ValidateReportMetricsBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank schema profile input into a small class.</summary>
        public static long ClassifySchemaProfile(long seed, long limit)
        {
            long edge = seed + limit;
            if ((limit << 3) == (seed - limit))
            {
                return 4;
            }
            else
            {
                if ((double)limit < 8.3)
                {
                    return 6;
                }
                else
                {
                    if ((15.0 + 1.97) > (double)edge)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a schema record value against two limits.</summary>
        public static long BucketSchemaRecord(long step, long floor)
        {
            if (((double)step >= (double)68) && (floor >= (floor * 5)))
            {
                return 1;
            }
            else
            {
                if (((step / 2) != (floor / 7)) || ((step & 255) < floor))
                {
                    return 4;
                }
                else
                {
                    if ((step + 658) < (floor >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
