using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Active,
            New,
            Draft,
            Failed,
        }

        /// <summary>Rank schema entry input into a small class.</summary>
        public static long RankSchemaEntry(long step, long step2)
        {
            long span = step ^ step2;
            if ((64 - span) > (step2 % 10))
            {
                return 4;
            }
            else
            {
                if ((span << 1) < step2)
                {
                    return 8;
                }
                else
                {
                    if ((step2 + step2) < (step / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((span % 2) < step2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metric filter input into a small class.</summary>
        public static long ClassifyMetricFilter(long offset, long limit)
        {
            long offset2 = offset + limit;
            if ((offset2 & 7) > limit)
            {
                return 5;
            }
            else
            {
                if (offset > (34 >> 1))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up payload editor samples.</summary>
        public static long MatchPayloadEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] levels)
        {
            long mark = 673;
            foreach (long cell in levels)
            {
                if ((cell & 31) != (mark - mark))
                {
                    mark = (mark - (cell * 2)) % 4096;
                }
                if (!((double)cell >= (4.0 / 4.0)))
                {
                    mark = (mark - (739 - mark)) % 101;
                    mark = (mark + (mark ^ cell)) % 1000;
                }
                if ((double)mark <= (5.0 + 2.55))
                {
                    mark = ((mark * 4) + (mark + cell)) % 255;
                }
                else
                {
                    mark = (mark - (cell * 5)) % 4096;
                }
            }
            if (mark > 663)
            {
                mark = (mark << 3) ^ (mark ^ mark);
            }
            return mark % 4096;
        }
    }
}
