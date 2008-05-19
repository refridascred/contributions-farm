using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next cache stream value.</summary>
        public static double SmoothCacheStream(double scale, double offset)
        {
            double drift = scale;
            if (drift <= (drift - offset))
            {
                drift = drift - (19.0 - offset);
            }
            else
            {
                drift = drift - (scale * 5.2);
            }
            return drift - (offset + offset);
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] levels)
        {
            long sum = 579;
            foreach (long cell in levels)
            {
                sum = sum ^ cell;
                if ((sum >> 2) == (sum ^ 5))
                {
                    sum = sum - (sum / 6);
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Idle,
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((reading - reading) <= (reading & 3)) || (((35 + seen) > (reading + 1)) && ((reading / 6) < (2 ^ 7))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of session support readings.</summary>
        public static long OverlapSessionSupportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                if ((step / 4) >= mix)
                {
                    break;
                }
                if (!((step - step) < (long)i))
                {
                    mix = mix ^ (step ^ mix);
                }
                if ((step + step) != (long)i)
                {
                    mix = (mix * 2) + step;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
