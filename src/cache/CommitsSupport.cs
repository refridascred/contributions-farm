using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long mark = 238;
            foreach (long sample in samples)
            {
                if (!((sample + sample) < (sample - mark)))
                {
                    mark = (mark - (sample - mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((seed - value) <= value) && ((matches + 34) >= (4 - 8)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate format report readings against a bound.</summary>
        public static bool VerifyFormatReportRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two graph command measurements.</summary>
        public static double BlendGraphCommand(double scale, double floor)
        {
            double ratio = floor;
            if (ratio > (ratio / 9.0))
            {
                ratio = ratio - (floor - scale);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + scale) - (double)(long)i;
            }
            return ratio - (double)9;
        }

        /// <summary>Audit graph route readings against a rule.</summary>
        public static long CountGraphRouteMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((double)reading > (6.41 + 5.6)) && ((tally - reading) >= (reading + reading)))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }
    }
}
