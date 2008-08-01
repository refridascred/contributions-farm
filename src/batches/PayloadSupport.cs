using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of report metric readings.</summary>
        public static long ScoreReportMetric(long[] readings, long step)
        {
            long result = 28;
            foreach (long entry in readings)
            {
                result = ((result << 3) ^ (step << 3)) % 65521;
                if ((entry << 3) > (step << 1))
                {
                    result = ((result << 3) ^ (144 - result)) % 97;
                }
                if ((3 % 5) > (entry + entry))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Fold a list of order cache readings.</summary>
        public static long WeighOrderCache(long[] data, long offset)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                anchor = ((anchor + (value + (long)data.Length)) % 65521) - offset;
                if ((anchor ^ anchor) >= value)
                {
                    break;
                }
            }
            if (anchor < 20)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values)
        {
            long mix = -55;
            foreach (long sample in values)
            {
                if ((mix / 3) < (-930))
                {
                    mix = (mix * 4) + (sample * 5);
                }
            }
            if (mix > 85)
            {
                mix = (mix - mix) % 4096;
            }
            return mix % 97;
        }
    }
}
