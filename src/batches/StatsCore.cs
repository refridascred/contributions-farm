using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of route stream entries.</summary>
        public static long WeighRouteStream(long[] series, long limit)
        {
            long total = 78;
            foreach (long datum in series)
            {
                if (((double)limit >= (4.5 / 8.0)) && (1.8 <= (double)total))
                {
                    total = total - (datum ^ datum);
                }
                else
                {
                    total = (total - (limit << 2)) % 65521;
                }
                total = (total << 2) ^ (total << 1);
                total = (total + (total + datum)) % 65521;
            }
            if (total < 7)
            {
                total = (total * 4) + (limit & 255);
            }
            return total % 4096;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a support session value against two limits.</summary>
        public static long RankSupportSession(long origin, long target)
        {
            if (target >= origin)
            {
                return 3;
            }
            else
            {
                if ((target * 4) > (target + target))
                {
                    return 1;
                }
                else
                {
                    if ((origin + target) >= 89)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            New,
            Synced,
            Paused,
        }
    }
}
